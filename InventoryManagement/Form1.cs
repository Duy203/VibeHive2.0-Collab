using AlbumInventoryAPI;
using Grpc.Net.Client;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_addAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum addAlbum = new AddAlbum();
            addAlbum.Show();
        }

        private void btn_getAlbum_Click(object sender, EventArgs e)
        {
            GetAlbumById getAlbum = new GetAlbumById();
            getAlbum.Show();
        }

        private void btn_updateAlbum_Click(object sender, EventArgs e)
        {
            UpdateAlbum updateAlbum = new UpdateAlbum();
            updateAlbum.Show();
        }

        private void btn_deleteAlbum_Click(object sender, EventArgs e)
        {
            DeleteAlbum deleteAlbum = new DeleteAlbum();
            deleteAlbum.Show();
        }

        private void btn_listAlbums_Click(object sender, EventArgs e)
        {
            ListAlbums listAlbums = new ListAlbums(listResponse);
            listAlbums.Show();
        }
    }
}
