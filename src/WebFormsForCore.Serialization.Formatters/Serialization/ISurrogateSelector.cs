// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace EstrellasDeEsperanza.WebFormsForCore.Serialization.Formatters.Binary
{
    public interface ISurrogateSelector
    {
        void ChainSelector(ISurrogateSelector selector);
        ISerializationSurrogate? GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
        ISurrogateSelector? GetNextSelector();
    }
}
