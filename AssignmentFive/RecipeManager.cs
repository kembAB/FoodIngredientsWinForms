using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFive
{
    public class RecipeManager
    {
        private Recipe[] recipeList;

        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }
        private int FindVacantPostion()
        {
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] == null)
                    return index;
            }
            return -1;
        }

        public Recipe GetRecipeAt(int index)
        {
            Recipe _index;
            if (CheckIndex(index))
                _index = recipeList[index];
            else
                _index = null;
            return _index;
        }
        public bool CheckIndex(int _index)
        {
            bool found = false;
            for (; _index < recipeList.Length;)
            {
                if (recipeList[_index] != null)
                    found = true;
                _index += 1;
                break;
            }

            return found;

        }
        public bool Add(Recipe newRecipe)
        {
            bool ok = true;
            return ok;
        }

        public bool ChangeElement(int index, Recipe recipe) { return true; }
        public bool DeleteElement(int index) { return true; }
        public int GetCurrentNUmOfItems()
        {
            int count = 0;
            for (int index = 0; index < recipeList.Length; index++)
            {
                if (recipeList[index] != null)
                    count++;
            }
            return count;
        }
        public int NumOfItems
        {
            get
            {
                return NumOfItems;
            }
        }
       
    }
}
