using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.memento
{
    class History
    {
        private Stack<EditorState> states =  new Stack<EditorState>();

        public void push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState pop()
        {
            return states.Pop();
        }
    }
}
