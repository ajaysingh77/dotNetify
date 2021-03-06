﻿using System;
using System.Collections.Generic;
using DotNetify;
using DotNetify.Routing;

namespace ViewModels
{
   public class IndexVM : BaseVM, IRoutable
   {
      public class Link
      {
         public string Id => Route.TemplateId;
         public Route Route { get; set; }
         public string Caption { get; set; }
         public string Description { get; set; }
      }

      public RoutingState RoutingState { get; set; }

      public List<Link> BasicExampleLinks => new List<Link>
      {
         new Link { Route = this.GetRoute("HelloWorld"), Caption = "Hello World", Description = "Getting familiar with the basics"  },
         new Link { Route = this.GetRoute("ControlTypes"), Caption = "Control Types", Description = "Using various HTML control types"  },
         new Link { Route = this.GetRoute("SimpleList"), Caption = "Simple List", Description = "Simple CRUD List"  }
      };

      public List<Link> FurtherExampleLinks => new List<Link>
      {
         new Link { Route = this.GetRoute("GridView"), Caption = "Grid View", Description = "More complex list with master-detail view, search, sorting and localization"  },
      };

      public IndexVM()
      {
         this.RegisterRoutes("demo", new List<RouteTemplate>
         {
            new RouteTemplate { Id = "Home", UrlPattern = "", Target = "Content", ViewUrl = "HelloWorld", JSModuleUrl = "/state/get/HelloWorldVM, /js/HelloWorld.jsx" },
            new RouteTemplate { Id = "HelloWorld", UrlPattern = "helloworld", Target = "Content", ViewUrl = "HelloWorld", JSModuleUrl = "/state/get/HelloWorldVM, /js/HelloWorld.jsx" },
            new RouteTemplate { Id = "ControlTypes", UrlPattern = "controltypes", Target = "Content", ViewUrl = "ControlTypes", JSModuleUrl = "/state/get/ControlTypesVM, /js/ControlTypes.jsx" },
            new RouteTemplate { Id = "SimpleList", UrlPattern = "simplelist", Target = "Content", ViewUrl = "SimpleList", JSModuleUrl = "/state/get/SimpleListVM, /js/SimpleList.jsx" },
            new RouteTemplate { Id = "GridView", UrlPattern = "gridview", Target = "Content", ViewUrl = "GridView", JSModuleUrl = "/state/get/GridViewVM, /js/GridView.jsx" },
         });
      }
   }
}
