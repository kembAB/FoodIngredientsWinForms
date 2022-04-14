using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    public class Recipe
    {
        //an array to store respective ingredients of each receipe 
        private string[] ingredientArray;
        private string name;//receipe name
        private FoodCategory catagory;//from enum catagory
        private string description;//cooking instruction
        private string catagorystring;
       // FormIngredient frmi;
        
        
        public Recipe(int MaxNumOfIngredients)
        {
            
            ingredientArray = new string[MaxNumOfIngredients];
            DefaultValues();

        }
        public void ClearIngredients()
        {
            //string[] ingredientArray = null;
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                //(ingredientArray[index]) = null;
                ingredientArray[index] = string.Empty;
            }
        }
      
        public void DefaultValues()
        {
            for (int index = 0; index < ingredientArray.Length; index++)
            { ingredientArray[index] = string.Empty; }
                


                name = string.Empty;
                catagory = FoodCategory.Vegetarian;
                description = string.Empty;



            
        }
        public int MaxNumOfIngredients
        {
            get { return ingredientArray.Length; }

        }
        //to store each ingredient a vacant position in ingredient is located 
        //called by AddIngredient function
        public int FindVacantPosition()
        {

            int _index = 0;


            for (int index = 0; index < MaxNumOfIngredients; index++)
            {
                if (string.IsNullOrEmpty(ingredientArray[index]))
                {
                    _index = index;
                    break;
                }

                else if (!string.IsNullOrEmpty(ingredientArray[index]) && index >= ingredientArray.Length - 1)
                {
                    _index = -1;
                    break;
                }


            }
            return _index;
        }
        public string GetcatagoryString()
        {
            // GET THE PRIORITY TYPE AND RETURN IT 
            // _priorit = priorit;
        
            switch (catagory)
            {

                case FoodCategory.Meat:
                    catagorystring = "meat";
                    break;
                case FoodCategory.Vegetarian:
                    catagorystring = "vegetarian";
                    break;
                case FoodCategory.Fish:
                    catagorystring = "fish";
                    break;
                case FoodCategory.Seafood:
                    catagorystring = "seafood";
                    break;
               
            }



            return catagorystring;


        }


        //step 2 
        //after the ok button in the ingredients form is clicked the ingredients will be stored in 
        //the vacant position of ingredient array 
        public bool AddIngredient(string value)
        {
            bool ok = true;
            int _index = FindVacantPosition();
            //add value  ingredient in _index location 
            ingredientArray[_index] = value;
            if (_index >= 0)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
            
            return ok;
        }
        public bool checkIndex(int _index)
        {
            bool ok = true;
            for (int index = 0; index < ingredientArray.Length; index++)
            {
                if (0 <= _index && _index <= ingredientArray.Length)

                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
               
             
                   
                    return ok;
        }
        

        public int GetCurrentNumOfIngredients()
        {
            //  get current number of ingredients
            
            int count = 0;
            for (int index = 0; index <ingredientArray.Length; index++)
            {
                if (!string.IsNullOrEmpty(ingredientArray[index]))
                {
                    count ++;
                }
                //else
                //    continue;
              //return  count


            }
            return count;
           
        }
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);
            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No Description";

           
            string textOut = string.Format("{0,-30}{1,-25}{2,-16}{3,-14}", name, GetCurrentNumOfIngredients(), GetcatagoryString(), descriptionText);
            return textOut;
        }
        public bool ChangeIngredientAt(int index,string value)
        {
            bool bok = true;
            if (checkIndex(index))
                ingredientArray[index] = value;
            else
                bok = false;
            return bok;
        }

        public string FormatDescription()
        {
            string textOut = string.Empty;
            for(int i = 0; i < ingredientArray.Length; i++)
            {
                string ingredient = ingredientArray[i];
                if(!string.IsNullOrEmpty(ingredient))
                {
                    textOut += ingredient + Environment.NewLine;
                }
            }
            return textOut;
        }
        public string FormatDescription(int maxLength)
        {
            string descritionText = string.Empty;
            if (string.IsNullOrEmpty(description))
                descritionText = "No description";
            else
            {
                int length = Math.Min(description.Length, maxLength);
                descritionText = description.Substring(0, length);
            }
            return descritionText;
        }
        public string FormatIngredients()
        {
            return FormatDescription(description.Length);
        }

        public bool DelteIngredietAt(int index)
        {
            bool bok = true;
            if (checkIndex(index))
                bok = true;
               // ingredientArray[index] = value;
          
            return bok;
        }
        public FoodCategory Catagory
        {
            get
            {
                return (FoodCategory.Vegetarian == catagory) ? FoodCategory.Vegetarian : catagory;
            }
               set
            {
                catagory = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
         public string[] Ingredients
        {
            get
            {
                return ingredientArray;
            }
            set
            {
                ingredientArray = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    
    

    
}
