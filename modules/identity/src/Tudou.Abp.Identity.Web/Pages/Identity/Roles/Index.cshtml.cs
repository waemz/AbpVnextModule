﻿using System.Threading.Tasks;

namespace Tudou.Abp.Identity.Web.Pages.Identity.Roles
{
    public class IndexModel : IdentityPageModel
    {
        public virtual Task OnGetAsync()
        {
            return Task.CompletedTask;
        }

        public virtual Task OnPostAsync()
        {
            return Task.CompletedTask;
        }
    }
}