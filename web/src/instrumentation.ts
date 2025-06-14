import "server-only";
import { useAzureMonitor } from "@azure/monitor-opentelemetry";

export function register() {
  if (process.env.APPLICATIONINSIGHTS_CONNECTION_STRING) {
    // eslint-disable-next-line react-hooks/rules-of-hooks
    useAzureMonitor();
  }
}
