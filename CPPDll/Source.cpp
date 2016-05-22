#include <string>
#include <Windows.h>

extern "C" __declspec(dllexport) void __stdcall retString(char** strRet)
{
	//std::string str = "HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界";
	strcpy(*strRet, "HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界");
}

extern "C" __declspec(dllexport) void __stdcall retStringIntPtr(char** strRet)
{
	std::string str = "HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界HelloWorld哈喽世界";
	*strRet = (char*)::CoTaskMemAlloc(str.length() + 1);
	strcpy(*strRet, str.c_str());
}

extern "C" __declspec(dllexport) int __stdcall retInt()
{
	return 100;
}