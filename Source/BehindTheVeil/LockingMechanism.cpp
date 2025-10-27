// Fill out your copyright notice in the Description page of Project Settings.


#include "LockingMechanism.h"

// Sets default values
ALockingMechanism::ALockingMechanism()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	Tags.Add("CollectableItem");

}

// Called when the game starts or when spawned
void ALockingMechanism::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ALockingMechanism::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

