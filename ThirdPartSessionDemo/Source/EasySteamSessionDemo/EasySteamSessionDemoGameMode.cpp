// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

#include "EasySteamSessionDemoGameMode.h"
#include "EasySteamSessionDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AEasySteamSessionDemoGameMode::AEasySteamSessionDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
