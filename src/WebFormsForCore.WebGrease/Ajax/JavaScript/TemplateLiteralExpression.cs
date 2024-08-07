﻿// TemplateLiteralExpression.cs
//
// Copyright 2013 Microsoft Corporation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Microsoft.Ajax.Utilities
{
    public class TemplateLiteralExpression : AstNode
    {
        private AstNode m_expression;

        public AstNode Expression
        {
            get { return m_expression; }
            set
            {
                m_expression.IfNotNull(n => n.Parent = (n.Parent == this) ? null : n.Parent);
                m_expression = value;
                m_expression.IfNotNull(n => n.Parent = this);
            }
        }

        public string Text { get; set; }

        public Context TextContext { get; set; }

        public TemplateLiteralExpression(Context context)
            : base(context)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override IEnumerable<AstNode> Children
        {
            get
            {
                return EnumerateNonNullNodes(m_expression);
            }
        }

        public override bool ReplaceChild(AstNode oldNode, AstNode newNode)
        {
            if (Expression == oldNode)
            {
                Expression = newNode;
                return true;
            }

            return false;
        }
    }
}
