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
    public partial class DeleteAlbum : Form
    {
        public DeleteAlbum()
        {
            InitializeComponent();
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7254");
            var client = new InventoryService.InventoryServiceClient(channel);

            var deleteResponse = await client.DeleteAlbumAsync(new DeleteAlbumRequest { AlbumId = textBox_Delete.Text });
            MessageBox.Show($"Deleted Album with ID {deleteResponse.AlbumId}");
        }
    }
}
