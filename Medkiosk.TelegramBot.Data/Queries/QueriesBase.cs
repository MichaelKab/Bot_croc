using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Croc.Medkiosk.TelegramBot.Data.Queries
{
    public abstract class QueriesBase
    {
        protected readonly IDbContextFactory<newmed2_dockerContext> ContextFactory;
        protected readonly ILogger Logger;

        protected QueriesBase(
            IDbContextFactory<newmed2_dockerContext> contextFactory,
            ILogger logger)
        {
            ContextFactory = contextFactory;
            Logger = logger;
        }
    }
}