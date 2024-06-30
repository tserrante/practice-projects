#include "miniaudio.h"

#include<stdio.h>


extern __declspec(dllexport) void data_callback(ma_device* pDevice, void* pOutput, const void* pInput, ma_uint32 frameCount)
{
    
    ma_decoder* pDecoder = (ma_decoder*)pDevice->pUserData;
    if (pDecoder == NULL) {
        return;
    }

    ma_decoder_read_pcm_frames(pDecoder, pOutput, frameCount, NULL);

    (void)pInput;
}



extern __declspec(dllexport) void Test()
{
    printf("Test Successful!");
}

//extern "C" __declspec(dllexport) void Test()
//{
//	std::cout << "Test Successful!" << std::endl;
//}