/**
 * The invoker asks the command to carry out the request.
 * It is bound to one specific command at any given time.
 */
public class Invoker {

  private Command command;

  public void setCommand(Command command) {
    this.command = command;
  }

  public void executeCommand() {
    this.command.execute();
  }

}