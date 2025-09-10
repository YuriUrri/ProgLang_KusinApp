using KusinApp;

namespace KusinApp
{
    public partial class MainPage : Form
    {
        private List<string> allItems = new List<string>
        {
            "apple", "banana", "grape","great", "mango", "orange", "pear"
        };

        private List<Recipe> allRecipes = new List<Recipe>
        {
             new Recipe("Kare-kare", "images/apple_pie.png", new List<string> { "pork belly", "garlic", "dried bay leaves","tablespoons vinegar" +
                 "soy sauce" ,"peppercorn" , "water", "salt" }),
        };
        public MainPage()
        {
            InitializeComponent();
            searchBox.KeyDown += searchBox_KeyDown;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e) // searchBox
        {
            // Always configure AutoComplete for searchBox
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;  // show dropdown only
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string inQueue = searchBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(inQueue))
            {
                searchBox.AutoCompleteCustomSource = null;
                return;
            }

            // Filter items dynamically
            var results = allItems
                .Where(item => item.ToLower().Contains(inQueue))
                .ToArray();

            if (results.Any())
            {
                AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();
                suggestions.AddRange(results);
                searchBox.AutoCompleteCustomSource = suggestions;
            }
            else
            {
                searchBox.AutoCompleteCustomSource = null;
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            // Handle Account button click
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//suggestion box      
        {
            suggestionBox.Visible = false;
            if (suggestionBox.SelectedItem != null)
            {
                searchBox.Text = suggestionBox.SelectedItem.ToString();
                suggestionBox.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//add button
        {
            AddItem();
        }

        private void AddItem()
        {
            string itemToAdd = "";

            // Priority: if a suggestion is selected, take that
            if (suggestionBox.Visible && suggestionBox.SelectedItem != null)
            {
                itemToAdd = suggestionBox.SelectedItem.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(searchBox.Text))
            {
                // Otherwise take whatever is typed in
                itemToAdd = searchBox.Text.Trim();
            }

            if (!string.IsNullOrEmpty(itemToAdd))
            {
                // Avoid duplicates (optional)
                if (!itemList.Items.Contains(itemToAdd))
                {
                    itemList.Items.Add(itemToAdd);
                }

                // Clear search box or keep it, depending on your preference
                searchBox.Clear();
                suggestionBox.Visible = false;
            }

        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItem();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //recipe suggestion box
        {

        }

    }
}

