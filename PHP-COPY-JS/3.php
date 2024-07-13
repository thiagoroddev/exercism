<?php

function canSpy($knightIsAwake, $archerIsAwake, $prisonerIsAwake) {
    if ($knightIsAwake === true || $archerIsAwake === true || $prisonerIsAwake === true) {
        echo "True\n";
        return true;
    } else {
        echo "False\n";
        return false;
    }
}

echo canSpy(false, false, false) . "\n";

/*
  * Você será pego pelo arqueiro se sinalizar enquanto ele estiver acordado.
  *
  * @param {boolean} arqueiroIsAwake
  * @param {boolean} prisioneiroIsAwake
  *
  * @returns {boolean} Se você pode ou não enviar um sinal ao prisioneiro.
  */

function canSignalPrisoner($archerIsAwake, $prisonerIsAwake) {
    if ($archerIsAwake === false && $prisonerIsAwake === true) {
        echo "True\n";
        return true;
    } else {
        echo "False\n";
        return false;
    }
}

echo canSignalPrisoner(false, true) . "\n";

/*
  * A etapa final do plano: libertar a melhor amiga de Annalyn.
  *
  * @param {boolean} knightIsAwak
