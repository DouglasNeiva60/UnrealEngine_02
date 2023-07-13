// Copyright Epic Games, Inc. All Rights Reserved.

#include "C_SC_RTD_MT_WSCGameMode.h"
#include "C_SC_RTD_MT_WSCCharacter.h"
#include "UObject/ConstructorHelpers.h"

AC_SC_RTD_MT_WSCGameMode::AC_SC_RTD_MT_WSCGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
