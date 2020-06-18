using EasyRadio.Opus.Api;

namespace EasyRadio.Opus
{
    public class OpusPacketApi
    {
        private readonly IOpusApi _api;

        internal OpusPacketApi(IOpusApi api)
        {
            _api = api;
        }

        public int GetNbSamples(byte[] packet, int len, int fs)
        {
            return _api.opus_packet_get_nb_samples(packet, len, fs);
        }
    }
}
