#include <string>
#include <Windows.h>

extern "C" __declspec(dllexport) void __stdcall retString(char** strRet)
{
	//std::string str = "HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������";
	strcpy(*strRet, "HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������");
}

extern "C" __declspec(dllexport) void __stdcall retStringIntPtr(char** strRet)
{
	std::string str = "HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������HelloWorld�������";
	*strRet = (char*)::CoTaskMemAlloc(str.length() + 1);
	strcpy(*strRet, str.c_str());
}

extern "C" __declspec(dllexport) int __stdcall retInt()
{
	return 100;
}