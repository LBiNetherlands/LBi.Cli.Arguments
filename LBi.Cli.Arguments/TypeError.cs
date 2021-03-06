/*
 * Copyright 2012 LBi Netherlands B.V.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using LBi.Cli.Arguments.Parsing.Ast;

namespace LBi.Cli.Arguments
{
    public class TypeError : ValueError
    {
        public TypeError(Type targetType, object value, AstNode astNode, IEnumerable<Exception> exceptions)
            : this(targetType, value, astNode, exceptions.ToArray())
        {
            
        }

        public TypeError(Type targetType, object value, AstNode astNode, params Exception[] exceptions)
        {
            this.TargetType = targetType;
            this.Value = value;
            this.AstNode = astNode;
            this.Exceptions = exceptions;
        }

        public Exception[] Exceptions { get; protected set; }
        public Type TargetType { get; protected set; }
        public object Value { get; protected set; }

        /// <summary>
        /// The <see cref="AstNode"/> representing the value.
        /// </summary>
        /// <remarks>Can be null.</remarks>
        public AstNode AstNode { get; protected set; }
    }
}