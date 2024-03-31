// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

#include "FlyingAIDemoGameMode.h"
#include "FlyingAIDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AFlyingAIDemoGameMode::AFlyingAIDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
