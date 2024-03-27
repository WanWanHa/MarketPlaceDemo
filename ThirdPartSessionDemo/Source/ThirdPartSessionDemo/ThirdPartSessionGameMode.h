// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameMode.h"
#include "ThirdPartSessionGameMode.generated.h"

/**
 * 
 */
UCLASS()
class THIRDPARTSESSIONDEMO_API AThirdPartSessionGameMode : public AGameMode
{
	GENERATED_BODY()
	

public:

	virtual void PostLogin(APlayerController* NewPlayer) override;
};
