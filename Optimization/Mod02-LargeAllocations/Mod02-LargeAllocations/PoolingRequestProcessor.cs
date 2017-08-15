using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_LargeAllocations
{
    class PoolingRequestProcessor : RequestProcessor
    {
        private BufferManager _bufferManager;

        private const long MAX_POOL_SIZE = 256 * 1024 * 1024; //256 MB
        private const int MAX_BUFFER_SIZE = 16 * 1024 * 1024; //16 MB

        public PoolingRequestProcessor()
        {
            _bufferManager = BufferManager.CreateBufferManager(MAX_POOL_SIZE, MAX_BUFFER_SIZE);
        }

        protected override byte[] GetBuffer(int size)
        {
            // We don't want the pool to be polluted with buffers of different sizes.
            // We use only a few buffer sizes, so that there is more reuse at the
            // expense of wasting some space in the buffers.
            int realSize = (int)Math.Pow(2, (int)Math.Log(size, 2) + 1);
            return _bufferManager.TakeBuffer(realSize);
        }

        protected override void ReturnBuffer(byte[] buffer)
        {
            _bufferManager.ReturnBuffer(buffer);
        }
    }
}
