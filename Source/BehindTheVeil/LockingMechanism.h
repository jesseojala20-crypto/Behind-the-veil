// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "LockingMechanism.generated.h"

UCLASS()
class BEHINDTHEVEIL_API ALockingMechanism : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	ALockingMechanism();
	
	UPROPERTY(EditAnyWhere)
	FString ItemName; //this enables us to give the items a different names
protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
