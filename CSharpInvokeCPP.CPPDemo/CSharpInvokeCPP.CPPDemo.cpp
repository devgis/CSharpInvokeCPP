// CSharpInvokeCPP.CPPDemo.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "malloc.h"
#include "userinfo.h"

typedef struct {
	char name[32];
	int age;
} User;  

UserInfo* userInfo;

extern "C" __declspec(dllexport) int Add(int x, int y) 
{ 
	return x + y; 
}
extern "C" __declspec(dllexport) int Sub(int x, int y) 
{ 
	return x - y; 
}
extern "C" __declspec(dllexport) int Multiply(int x, int y) 
{ 
	return x * y; 
}
extern "C" __declspec(dllexport) int Divide(int x, int y) 
{ 
	return x / y; 
}

extern "C" __declspec(dllexport) User* Create(char* name, int age)    
{   
	User* user = (User*)malloc(sizeof(User));

	userInfo = new UserInfo(name, age);
	strcpy(user->name, userInfo->GetName());  
	user->age = userInfo->GetAge();

	return user; 
}             
