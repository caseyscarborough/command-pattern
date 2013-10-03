/**
 * This is an actual command. It implements the Command interface
 * and it defines the binding between the receiver object and its
 * action. It implements the execute method by calling the corresponding
 * action on the receiver.
 */
public class ConcreteCommand implements Command {

  private Receiver receiver;

  public ConcreteCommand(Receiver receiver) {
    this.receiver = receiver;
  }

  public void execute() {
    receiver.action();
  }

}