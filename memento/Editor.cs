using System;

namespace design_patterns.memento
{
    public class Editor
    {
        public string Content { get; set;  }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void restore(EditorState state)
        {
            Content = state.Content;
        }


    }
}