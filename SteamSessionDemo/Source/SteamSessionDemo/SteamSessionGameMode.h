// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameMode.h"
#include "SteamSessionGameMode.generated.h"

/**
 * 
 */
UCLASS()
class STEAMSESSIONDEMO_API ASteamSessionGameMode : public AGameMode
{
	GENERATED_BODY()
	

public:

	virtual void PostLogin(APlayerController* NewPlayer) override;
};
