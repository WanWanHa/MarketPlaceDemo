// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.


#include "ThirdPartSessionGameMode.h"
#include "GameFramework/GameStateBase.h"


void AThirdPartSessionGameMode::PostLogin(APlayerController* NewPlayer)
{
	Super::PostLogin(NewPlayer);

	int32 NumOfPlayers = GameState.Get()->PlayerArray.Num();
	if (NumOfPlayers >= 2)
	{
		UWorld* World = GetWorld();
		if (World)
		{
			bUseSeamlessTravel = true;
			World->ServerTravel(FString("/Game/ThirdPerson/Maps/Lobby?listen"));
		}
	}
}
