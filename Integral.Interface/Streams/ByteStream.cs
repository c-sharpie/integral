using System;
using System.Threading.Tasks;
using Integral.Abstractions;

namespace Integral.Streams
{
    public interface ByteStream : ReadStream<Memory<byte>, ValueTask<int>>, WriteStream<ReadOnlyMemory<byte>, ValueTask>, Disposable
    {
    }
}