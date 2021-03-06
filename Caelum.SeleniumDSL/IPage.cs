﻿using Caelum.SeleniumDSL.Selector;
using Caelum.SeleniumDSL.Table;

namespace Caelum.SeleniumDSL
{
    public interface IPage : IElement
    {
        IForm Form(ISelector selector);
        
        IContentTag Div(ISelector id);

        IContentTag Span(string id);

        ITable Table(string id);

        IPage Navigate(string element);

        IPage NavigateLink(string text);

        IPage Click(string element);

        IPage ClickLink(string text);

        IPage DoubleClick(string element);

        bool HasLink(string link);

        string Title();

        //Array Array(string Name);

        string Invoke(string cmd);

        IPage WaitUntil(string condition, long timeout);

        void Screenshot(string filePath);

        IPage Refresh();

        IPage MouseDown(string element);

        IPage MouseUp(string element);

        IPage DragAndDrop(string source, string destination);
    }
}