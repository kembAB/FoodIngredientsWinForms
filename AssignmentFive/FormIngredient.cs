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
    public partial class FormIngredient : Form
    {
        bool doNotClose = false;//use to prevent closing
        private Recipe m_recipe;
       
        public FormIngredient(Recipe recipe)
        {
            
            InitializeComponent();

            //if (m_recipe.Ingredients == null)
            //{
            //    MessageBox.Show("no ingredients", "missing data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            m_recipe = recipe;
            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No Recipe Name";
            else
                this.Text = recipe.Name + "Add ingredients";
         
            InitializeGUI();
        }
        public void InitializeGUI()
        {

            if (m_recipe.Ingredients == null)
                m_recipe.Ingredients = new string[m_recipe.MaxNumOfIngredients];
            lstIngredients.Items.Clear();
            
           
            lblMaxNum.Text = m_recipe.GetCurrentNumOfIngredients().ToString();
            
        }
        private void FormIngredient_Load(object sender, EventArgs e)
        {

        }
        public Recipe Recipe
        {
            get { return m_recipe; }
            set {if(value!=null)
                    m_recipe = value; }
        }
        private void UpdateGUI()
        {
            //display the number of ingredient in a label
            lblMaxNum.Text = lstIngredients.Items.Count+1.ToString();
            lstIngredients.Items.Clear();
           int  ingredientcount = 0;
            int index = 0;
            for (; index < m_recipe.MaxNumOfIngredients; index++)
            {
                if (!string.IsNullOrEmpty(m_recipe.Ingredients[index]))
                {
                    lstIngredients.Items.Add(m_recipe.Ingredients[index]);
                  
                    ingredientcount += 1;
                }
               
               

            }

           //count of ingredients printed on label
            lblMaxNum.Text= lstIngredients.Items.Count.ToString();
        
            txtIngredients.Text = string.Empty;
        }

        
        private void ClearIngredients()
        {

        }
        //the second form starts here 
        private void btnAdd_Click(object sender, EventArgs e)
        {


            

            //if(lstIngredients)
                                                                //check if the ingredient textbox is not empty 

            string ingredient = CheckIngredient();
            if (!String.IsNullOrEmpty(ingredient))
            {
               m_recipe.AddIngredient(ingredient);
                //lstIngredients.Text= txtIngredients.Text;
                UpdateGUI();

            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //inform the user that the user did not choose ingredients and continue
            if (m_recipe.MaxNumOfIngredients <= 0)
            {
                if (MessageBox.Show("No ingredients given.close?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    doNotClose = true;
                }
                else
                    //to be programmed--ingredients array is cleared from values
                    m_recipe.ClearIngredients();


            }
        }
      

        private string CheckIngredient()
        {

            string text = txtIngredients.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("no text specified", "Error");
                return null;
            }
            return text;
        }
        private void FormIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (doNotClose)
                e.Cancel = true;
            else
                e.Cancel = false;
            doNotClose = false;//reset
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_recipe.ClearIngredients();
        }
        
    }
}
