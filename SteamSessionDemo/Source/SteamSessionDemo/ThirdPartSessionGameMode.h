// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameMode.h"
#include "ThirdPartSessionGameMode.generated.h"

/**
 * 
 */
UCLASS()
class STEAMSESSIONDEMO_API AThirdPartSessionGameMode : public AGameMode
{
	GENERATED_BODY()
	

public:

	virtual void PostLogin(APlayerController* NewPlayer) override;
};
