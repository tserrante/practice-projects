
#include<iostream>

extern "C" __declspec(dllexport) void Test()
{
	std::cout << "Test Successful!" << std::endl;
}