﻿using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Agile.Cms.Core.Web.Menus;

public class CoreMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(CoreMenus.Prefix, displayName: "AgileCmsCore", "~/Core", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
