﻿namespace Phantasma.RpcClient.Api
{
    public enum ApiMethods
    {
        getABI,
        getAccount,
        getApps,
        getAddressTransactions,
        getAddressTxCount,
        getAuctions,
        getAuctionsCount,
        getBlockByHash,
        getRawBlockByHash,
        getBlockByHeight,
        getRawBlockByHeight,
        getBlockHeight,
        getBlockTransactionCountByHash,
        getChains,
        getPlatforms,
        getTransaction,
        getTransactionByBlockHashAndIndex,
        getTokens,
        getTokenData,
        getTokenTransfers,
        getTokenTransferCount,
        sendRawTransaction,
        lookUpName,
        invokeRawScript,
    }
}
