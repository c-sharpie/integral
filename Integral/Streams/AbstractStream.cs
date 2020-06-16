using System;
using System.IO;

namespace Integral.Streams
{
    public abstract class AbstractStream : Stream, ByteStream
    {
        public override long Length { get; } = 0;

        public override bool CanRead { get; } = true;

        public override bool CanWrite { get; } = true;

        public override bool CanSeek { get; } = false;

        public override long Position { get; set; }

        public override int Read(byte[] buffer, int offset, int count) => throw new NotImplementedException();

        public override void Write(byte[] buffer, int offset, int count) => throw new NotImplementedException();

        public override long Seek(long offset, SeekOrigin origin) => throw new NotImplementedException();

        public override void SetLength(long value) => throw new NotImplementedException();

        public override void Flush()
        {
        }
    }
}