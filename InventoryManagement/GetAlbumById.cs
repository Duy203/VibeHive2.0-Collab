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
    public partial class GetAlbumById : Form
    {
        public GetAlbumById()
        {
            InitializeComponent();
        }

        private async void button_Submit_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7254");
            var client = new InventoryService.InventoryServiceClient(channel);

            var albumGet = await client.GetAlbumAsync(new GetAlbumRequest { AlbumId = textBoxAlbumId.Text });

            MessageBox.Show($"Retrieved Album: ID: {albumGet.AlbumId}, Name: {albumGet.AlbumName}, Artist: {albumGet.Artist}, Year: {albumGet.Year}");
        }
    }
}
