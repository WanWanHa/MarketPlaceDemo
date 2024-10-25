// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameMode.h"
#include "EosSessionGameMode.generated.h"

/**
 * 
 */
UCLASS()
class EOSSESSIONDEMO_API AEosSessionGameMode : public AGameMode
{
	GENERATED_BODY()
	

public:

	virtual void PostLogin(APlayerController* NewPlayer) override;

};
