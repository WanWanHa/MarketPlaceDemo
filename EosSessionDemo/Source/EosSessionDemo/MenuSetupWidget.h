// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "SessionInterface.h"
#include "MenuSetupWidget.generated.h"

/**
 * 
 */
UCLASS()
class EOSSESSIONDEMO_API UMenuSetupWidget : public UUserWidget, public ISessionInterface
{
	GENERATED_BODY()
	

public:

	UFUNCTION(BlueprintCallable)
	virtual void FindSession(const UObject* WorldContextObject) override;

	UFUNCTION(BlueprintCallable)
	virtual void JoinSession(const UObject* WorldContextObject, const int32 SessionID) override;

	UFUNCTION(BlueprintCallable)
	virtual void DestroySession(const UObject* WorldContextObject, const FName& SessionName) override;

	UFUNCTION(BlueprintCallable)
	virtual void CreateSession(const UObject* WorldContextObject) override;

	UFUNCTION(BlueprintCallable)
	virtual void StartSession(const FName& SessionName, const UObject* WorldContextObject) override;

	UFUNCTION(BlueprintCallable)
	virtual void LoginEOS(const FString& Id, const FString& Token, const FString& Type, const UObject* WorldContextObject) override;


	UFUNCTION(BlueprintCallable, Category = "Initialize")
	void MenuSetup();

	void MenuTearDown();

protected:

	virtual bool Initialize() override;
	virtual void NativeConstruct() override;
	virtual void NativeDestruct() override;

};
