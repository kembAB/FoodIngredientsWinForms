using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    public partial class FormMain : Form
    {
        private const int numOfIngredients = 20;
        private const int maxNumOfElements = 50;
       
        Recipe currRecipe = new Recipe(numOfIngredients);
        RecipeManager recipeMngr = new RecipeManager(maxNumOfElements);
       
        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            btnAddRecipe.Enabled = false;
            cmbCatagory.Items.AddRange(Enum.GetNames(typeof(FoodCategory)));
            cmbCatagory.SelectedIndex = (int)FoodCategory.Vegetarian;
            
            toolTip1.SetToolTip(btnAddIngredients, "Add ingredients before saving");
            InitializeInputControls();
        }
        private bool IsListBoxItemsSElected(out int index)
        {
            index = lstRecipe.SelectedIndex;
            return index >= 0;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
           
            currRecipe.GetCurrentNumOfIngredients();
            
           
          // ReadInput();
            currRecipe.Catagory = (FoodCategory)cmbCatagory.SelectedIndex;
            currRecipe.Name = txtName.Text.Trim();
            currRecipe.Description = txtDescription.Text.Trim();
            currRecipe.GetCurrentNumOfIngredients();
            recipeMngr.Add(currRecipe);

            

            UpdateGUI();
            lstRecipe.Items.Add(currRecipe.ToString());
            //release currRecipe
            currRecipe = new Recipe(maxNumOfElements);
            currRecipe.DefaultValues();


            
           

        }
        private void ReadInput()
        {
            currRecipe.Catagory = (FoodCategory)cmbCatagory.SelectedIndex;
            currRecipe.Name = txtName.Text.Trim();
            currRecipe.Description = txtDescription.Text.Trim();
          
            recipeMngr.Add(currRecipe);
         
        }
        private bool CheckInput()
        {
            bool ok=false;

            txtName.Text = txtName.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name  must be given ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok= false;
            }
          else  if (currRecipe.MaxNumOfIngredients <= 0)
            {
                ok = true;
                
            }
            return ok;
        }
        //step 1 program starts after the descritpion is entered in textbox and clicking AddIngredients button
        //line 7
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                //activate the add ingredient button
                ActivateButtons();
                //dlg.Receipe=currRecipe;
                FormIngredient dlg = new FormIngredient(currRecipe);
                DialogResult dlgResult = dlg.ShowDialog();
                if (dlgResult == DialogResult.OK)
                {
                    //clarification that the object of receipe get the updated info from ingredients form
                    currRecipe = dlg.Recipe;
                    if (currRecipe.GetCurrentNumOfIngredients() <= 0)
                    {
                        MessageBox.Show("No ingriendients specified");
                       recipeMngr.Add(currRecipe);
                        btnAddRecipe.Enabled = true;

                        UpdateGUI();
                    }
                }
            }
            else
                MessageBox.Show("Name  must be given ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void InitializeInputControls()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = "Add ingredient before saving the recipe.";
          
            
        }
        private bool IsListBoxItemsSelected(out int index)
        {
            index = lstRecipe.SelectedIndex;
            return index >= 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbCatagory.SelectedItem = FoodCategory.Vegetarian;
            cmbCatagory.SelectedIndex = (int)FoodCategory.Vegetarian;
        }
       public void  ActivateButtons()
        {
            btnAddRecipe.Enabled = true;
        }
        public void UpdateGUI()
        {
            lstRecipe.Items.Clear();
          
        

            InitializeInputControls();
            
        }

     

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the following code handles the case of selecting each member ot the foodcatagory Enumeration in the dropbox in the Recipe form(Formmain)
            FoodCategory selectedCatagory=(FoodCategory)Enum.Parse(typeof(FoodCategory), cmbCatagory.SelectedItem.ToString());
        }

     
    }
}
