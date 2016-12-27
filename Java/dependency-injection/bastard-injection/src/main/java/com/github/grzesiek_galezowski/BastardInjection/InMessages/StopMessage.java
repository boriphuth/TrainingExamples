﻿package com.github.grzesiek_galezowski.BastardInjection.InMessages;

import com.github.grzesiek_galezowski.BastardInjection.Interfaces.AcmeMessage;
import com.github.grzesiek_galezowski.BastardInjection.Interfaces.DataDestination;
import com.github.grzesiek_galezowski.BastardInjection.Services.IAuthorization;

public class StopMessage implements AcmeMessage {
  public void authorizeUsing(IAuthorization authorizationRules) {
    System.out.println("Authorizing Stop with " + authorizationRules);
  }

  public void writeTo(DataDestination dataDestination) {
    System.out.println("Writing Stop to " + dataDestination);
  }
}