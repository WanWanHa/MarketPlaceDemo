// // Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.


#include "MenuSetupWidget.h"

#include "SessionInterface.h"



void UMenuSetupWidget::FindSession(const UObject* WorldContextObject)
{
	ISessionInterface::FindSession(WorldContextObject);
}

void UMenuSetupWidget::JoinSession(const UObject* WorldContextObject, const int32 SessionID)
{
	ISessionInterface::JoinSession(WorldContextObject, SessionID);
}

void UMenuSetupWidget::DestroySession(const UObject* WorldContextObject, const FName& SessionName)
{
	ISessionInterface::DestroySession(WorldContextObject, SessionName);
}

void UMenuSetupWidget::CreateSession(const UObject* WorldContextObject)
{
	ISessionInterface::CreateSession(WorldContextObject);
}

void UMenuSetupWidget::StartSession(const FName& SessionName, const UObject* WorldContextObject)
{
	ISessionInterface::StartSession(SessionName, WorldContextObject);
}

void UMenuSetupWidget::LoginEOS(const FString& Id, const FString& Token, const FString& Type, const UObject* WorldContextObject)
{
	ISessionInterface::LoginEOS(Id, Token, Type, WorldContextObject);
}

void UMenuSetupWidget::MenuSetup()
{
	AddToViewport();
	SetVisibility(ESlateVisibility::Visible);
	SetIsFocusable(true);
	UWorld* WorldPtr = GetWorld();
	if (WorldPtr)
	{
		APlayerController* PC = WorldPtr->GetFirstPlayerController();
		if (PC)
		{
			FInputModeUIOnly InputModeData;
			InputModeData.SetWidgetToFocus(TakeWidget());
			InputModeData.SetLockMouseToViewportBehavior(EMouseLockMode::DoNotLock);
			PC->SetInputMode(InputModeData);
			PC->SetShowMouseCursor(true);
		}
	}
}

void UMenuSetupWidget::MenuTearDown()
{
	RemoveFromParent();

	UWorld* WorldPtr = GetWorld();
	if (WorldPtr)
	{
		APlayerController* PC = WorldPtr->GetFirstPlayerController();
		if (PC)
		{
			FInputModeGameOnly InputModeData;
			PC->SetInputMode(InputModeData);
			PC->SetShowMouseCursor(false);
		}
	}
}

bool UMenuSetupWidget::Initialize()
{
	if (!Super::Initialize()) return false;


	return true;
}

void UMenuSetupWidget::NativeConstruct()
{
	Super::NativeConstruct();

	ISessionInterface::InitSession(GetWorld());
}

void UMenuSetupWidget::NativeDestruct()
{
	Super::NativeDestruct();
	MenuTearDown();
}
