using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigureHub
{
    public class MenuActionService
    {
        private List<MenuAction> menuActionList;
        public MenuActionService() 
        {
            menuActionList = new List<MenuAction>();
        }

        public void AddMenuAction(int id, string name, string menuName)
        {
            MenuAction menuAction = new MenuAction() {Id = id, Name = name, MenuName = menuName };

            menuActionList.Add(menuAction);
        }


        public List<MenuAction> GetMenuActionList(string givenMenuName)
        {
            var resultList = new List<MenuAction>();

            foreach (var menuAction in menuActionList)
            {
                if(menuAction.MenuName == givenMenuName)
                {
                    resultList.Add(menuAction);
                }
            }

            return resultList;
        }
    }
}

