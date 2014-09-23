using System;
using System.Web.Mvc;

namespace StudyingApplication.Controllers
{
  public sealed class TestTagBuilder
  {
    private readonly string _tagName;

    public void AddClass()
    {
      throw new NotImplementedException();
    }

    public void AddAttribute()
    {
      throw new NotImplementedException();
    }

    public void MergeAttribute()
    {
      throw new NotImplementedException();
    }

    public void RemoveClass()
    {
      throw new NotImplementedException();
    }

    public void SetInnerText()
    {
      throw new NotImplementedException();
    }

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