// // Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "MenuSetupWidget.generated.h"

/**
 * 
 */
UCLASS()
class THIRDPARTSESSIONDEMO_API UMenuSetupWidget : public UUserWidget
{
	GENERATED_BODY()
	

public:

	UFUNCTION(BlueprintCallable, Category = "Initialize")
	void MenuSetup();

	void MenuTearDown();



protected:

	virtual bool Initialize() override;
	virtual void NativeDestruct() override;

};
