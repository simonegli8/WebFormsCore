// try.cs
//
// Copyright 2010 Microsoft Corporation
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
    public sealed class TryNode : AstNode
    {
        private Block m_tryBlock;
        private Block m_catchBlock;
        private Block m_finallyBlock;
        private ParameterDeclaration m_catchParameter;

        public Block TryBlock
        {
            get { return m_tryBlock; }
            set
            {
                m_tryBlock.IfNotNull(n => n.Parent = (n.Parent == this) ? null : n.Parent);
                m_tryBlock = value;
                m_tryBlock.IfNotNull(n => n.Parent = this);
            }
        }

        public Block CatchBlock
        {
            get { return m_catchBlock; }
            set
            {
                m_catchBlock.IfNotNull(n => n.Parent = (n.Parent == this) ? null : n.Parent);
                m_catchBlock = value;
                m_catchBlock.IfNotNull(n => n.Parent = this);
            }
        }

        public Block FinallyBlock
        {
            get { return m_finallyBlock; }
            set
            {
                m_finallyBlock.IfNotNull(n => n.Parent = (n.Parent == this) ? null : n.Parent);
                m_finallyBlock = value;
                m_finallyBlock.IfNotNull(n => n.Parent = this);
            }
        }

        public ParameterDeclaration CatchParameter
        {
            get { return m_catchParameter; }
            set
            {
                m_catchParameter.IfNotNull(n => n.Parent = (n.Parent == this) ? null : n.Parent);
                m_catchParameter = value;
                m_catchParameter.IfNotNull(n => n.Parent = this);
            }
        }

        public Context CatchContext { get; set; }

        public Context FinallyContext { get; set; }

        public TryNode(Context context)
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
                return EnumerateNonNullNodes(TryBlock, CatchParameter, CatchBlock, FinallyBlock);
            }
        }

        public override bool ReplaceChild(AstNode oldNode, AstNode newNode)
        {
            if (TryBlock == oldNode)
            {
                TryBlock = ForceToBlock(newNode);
                return true;
            }
            if (CatchParameter == oldNode)
            {
                return (newNode as ParameterDeclaration).IfNotNull(p =>
                    {
                        CatchParameter = p;
                        return true;
                    });
            }
            if (CatchBlock == oldNode)
            {
                CatchBlock = ForceToBlock(newNode);
                return true;
            }
            if (FinallyBlock == oldNode)
            {
                FinallyBlock = ForceToBlock(newNode);
                return true;
            }
            return false;
        }
    }
}
