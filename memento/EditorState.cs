using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.memento
{
    public class EditorState
    {
        public string Content { get; }
        public EditorState(string content)
        {
            this.Content = content;
        }

    }
}
