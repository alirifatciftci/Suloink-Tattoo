﻿using Microsoft.AspNetCore.Mvc;

namespace süleyman.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
