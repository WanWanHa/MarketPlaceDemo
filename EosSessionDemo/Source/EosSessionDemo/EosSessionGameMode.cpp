// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.


#include "EosSessionGameMode.h"
#include "GameFramework/GameStateBase.h"


void AEosSessionGameMode::PostLogin(APlayerController* NewPlayer)
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
