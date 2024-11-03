// Copyright 2024 (c) WanWanHa, LLC. All Rights Reserved.


#include "MenuSetupWidget.h"




void UMenuSetupWidget::MenuSetup()
{
	AddToViewport();
	SetVisibility(ESlateVisibility::Visible);
	bIsFocusable = true;
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

void UMenuSetupWidget::NativeDestruct()
{
	MenuTearDown();

	Super::NativeDestruct();
}
