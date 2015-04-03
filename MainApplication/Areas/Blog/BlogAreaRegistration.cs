using System.Web.Mvc;

namespace MainApplication.Areas.Blog
{
  public class BlogAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "Blog";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute(
          "Blog_default",
          "Blog/{controller}/{action}/{id}",
          new { action = "Index", id = UrlParameter.Optional },
          new string[] { "MainApplication.Areas.Blog.Controllers" }
      );
    }
  }
}
