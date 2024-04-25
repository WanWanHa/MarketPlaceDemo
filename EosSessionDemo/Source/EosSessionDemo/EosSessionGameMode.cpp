// Copyright WanWanHa NetWork Technology, LLC. All Rights Reserved.


#include "EosSessionGameMode.h"

#include "GameFramework/GameStateBase.h"
#include "Interfaces/OnlineIdentityInterface.h"
#include "Interfaces/OnlineSessionInterface.h"
#include "OnlineSubsystemUtils.h"
#include "OnlineSubsystem.h"



void AEosSessionGameMode::PostLogin(APlayerController* NewPlayer)
{
	Super::PostLogin(NewPlayer);

	if (!NewPlayer)
	{
		return;
	}

	FUniqueNetIdRepl UniqueNetIDRepl;
	if (NewPlayer->IsLocalController())
	{
		ULocalPlayer* LocalPlayerRef = NewPlayer->GetLocalPlayer();
		if (LocalPlayerRef)
		{
			UniqueNetIDRepl = LocalPlayerRef->GetPreferredUniqueNetId();
		}
		else
		{
			UNetConnection* RemoteNetConnectionRef = Cast<UNetConnection>(NewPlayer->Player);
			check(IsValid(RemoteNetConnectionRef));
			UniqueNetIDRepl = RemoteNetConnectionRef->PlayerId;
		}
	}
	else
	{
		UNetConnection* RemoteNetConnectionRef = Cast<UNetConnection>(NewPlayer->Player);
		check(IsValid(RemoteNetConnectionRef));
		UniqueNetIDRepl = RemoteNetConnectionRef->PlayerId;
	}

	TSharedPtr<const FUniqueNetId> UniqueNetId = UniqueNetIDRepl.GetUniqueNetId();
	check(UniqueNetId != nullptr);
	IOnlineSubsystem* SubsystemRef = Online::GetSubsystem(NewPlayer->GetWorld());
	IOnlineSessionPtr SessionRef = SubsystemRef->GetSessionInterface();
	bool bRegistrationSuccess = SessionRef->RegisterPlayer(FName("Test Session"), *UniqueNetId, false);
	if (bRegistrationSuccess)
	{
		UE_LOG(LogTemp, Warning, TEXT("Registration Successful"));
	}

}
