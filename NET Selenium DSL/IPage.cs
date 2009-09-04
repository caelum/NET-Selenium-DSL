using Caelum.SeleniumDSL;
using System;
namespace Caelum.SelenuimDSL
{
    public interface IPage
    {
        IForm Form(string Id);

        IContentTag Div(string Id);

        IContentTag Span(string Id);

        ITable Table(string Id);

        IPage Navigate(string Element);

        IPage NavigateLink(string Text);

        IPage Click(string Element);

        IPage ClickLink(string Text);

        IPage DoubleClick(string Element);

        bool HasLink(string Link);

        string Title();

        //Array Array(string Name);

        string Invoke(string Cmd);

        IPage WaitUntil(string Condition, long Timeout);

        void Screenshot(string FileName);

        IPage Refresh();

        IPage MouseDown(string Element);

        IPage MouseUp(string Element);

        IPage DragAndDrop(string FromElement, string ToElement);
    }
}
