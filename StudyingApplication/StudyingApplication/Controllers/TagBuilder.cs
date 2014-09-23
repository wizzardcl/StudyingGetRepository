using System.Web.Mvc;

namespace StudyingApplication.Controllers
{
  public sealed class TestTagBuilder
  {
    private readonly string _tagName;
    public void AddClass() { }
    public void AddAttribute() { }
    public void MergeAttribute() { }
    public void RemoveClass() { }
    public void SetInnerText() { }

    public TestTagBuilder(string tagName)
    {
      _tagName = tagName;
    }

    public string TagName { get { return _tagName; } }

    public MvcHtmlString ToHtmlString()
    {
      return new MvcHtmlString(string.Format("<{0}></{0}>", TagName));
    }
  }
}