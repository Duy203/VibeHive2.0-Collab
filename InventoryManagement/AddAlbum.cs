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
    public partial class AddAlbum : Form
    {
        public AddAlbum()
        {
            InitializeComponent();
            
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7254");
            var client = new InventoryService.InventoryServiceClient(channel);

            var createResponse = await client.AddAlbumAsync(new AddAlbumRequest { AlbumName = textBoxAlbumName.Text, Artist = textBoxArtist.Text, Year = Convert.ToInt32(textBoxYear.Text) });
            MessageBox.Show($"Added Album Successfully with ID: {createResponse.AlbumId}");
        }
    }
}
