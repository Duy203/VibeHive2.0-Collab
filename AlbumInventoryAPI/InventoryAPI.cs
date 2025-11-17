using Grpc.Core;
using System.Collections.Concurrent;

namespace AlbumInventoryAPI.Services
{
    public class InventoryAPI : AlbumInventoryAPI.InventoryService.InventoryServiceBase
    {
        private static readonly ConcurrentDictionary<string, GetAlbumResponse> albums = new();

        public override Task<AddAlbumResponse> AddAlbum(AddAlbumRequest request, ServerCallContext context)
        {
            var albumID = Guid.NewGuid().ToString();
            var album = new GetAlbumResponse
            {
                AlbumId = albumID,
                AlbumName = request.AlbumName,
                Artist = request.Artist,
                Year = request.Year
            };

            if(albums.TryAdd(albumID, album))
            {
                return Task.FromResult(new AddAlbumResponse { AlbumId = albumID });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to add this album"));
            }
        }

        public override Task<GetAlbumResponse> GetAlbum(GetAlbumRequest request, ServerCallContext context)
        {
            if(albums.TryGetValue(request.AlbumId, out var album))
            {
                return Task.FromResult(album);
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found for the albumID that was provided: {request.AlbumId}"))
            }
        }

        public override Task<UpdateAlbumResponse> UpdateAlbum(UpdateAlbumRequest request, ServerCallContext context)
        {
            foreach (var album in albums.Values)
            {
                if (album.AlbumId == request.AlbumId)
                {
                    var updatedAlbum = new UpdateAlbumResponse
                    {
                        AlbumId = request.AlbumId,
                        AlbumName = request.AlbumName,
                        Artist = request.Artist,
                        Year = request.Year
                    };
                    string albumId = album.AlbumId;
                    string requestAlbumId = request.AlbumId;
                    string updatedAlbumId = updatedAlbum.AlbumId;
                    if (albums.TryUpdate(albumId, updatedAlbumId, requestAlbumId))
                    {
                        return Task.FromResult(new UpdateAlbumResponse(updatedAlbum));
                    }
                    else
                    {
                        throw new RpcException(new Status(StatusCode.NotFound, $"No album exists with Id {request.AlbumId}"));
                    }
                }
            }
        }
        public override Task<DeleteAlbumResponse> DeleteAlbum(DeleteAlbumRequest request, ServerCallContext context)
        {
            if(albums.TryRemove(request.AlbumId, out var album))
            {
                return Task.FromResult<DeleteAlbumResponse>(new DeleteAlbumResponse());
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Could not delete album with {request.AlbumId}"));
            }
        }

        public override Task<ListAlbumResponse> ListAlbum(ListAlbumRequest request, ServerCallContext context)
        {
            if (!albums.IsEmpty)
            {
                foreach (var album in albums.Values)
                {
                    var listedAlbum = album;
                    var albumId = album.AlbumId;
                    albums.TryGetValue(albumId, out listedAlbum);
                }
                return Task.FromResult<ListAlbumResponse>(new ListAlbumResponse());
            }
        }

    }
}
