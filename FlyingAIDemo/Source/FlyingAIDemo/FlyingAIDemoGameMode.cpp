// Copyright Epic Games, Inc. All Rights Reserved.

#include "FlyingAIDemoGameMode.h"
#include "FlyingAIDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AFlyingAIDemoGameMode::AFlyingAIDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
