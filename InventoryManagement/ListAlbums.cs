using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumInventoryAPI;

namespace InventoryManagement
{
    public partial class ListAlbums : Form
    {
        public ListAlbums(ListAlbumResponse listResponse)
        {
            InitializeComponent();
            using var channel = GrpcChannel.ForAddress("https://localhost:7254");
            var client = new InventoryService.InventoryServiceClient(channel);

            listResponse = client.ListAlbum(new ListAlbumRequest());
            foreach (var album in listResponse)
            {
                listView1.Columns.Add(album);
            }
        }

    }
}
