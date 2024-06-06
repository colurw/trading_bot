/**
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator 2.4.42-SNAPSHOT.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * Address.h
 *
 * 
 */

#ifndef IO_SWAGGER_CLIENT_MODEL_Address_H_
#define IO_SWAGGER_CLIENT_MODEL_Address_H_


#include "../ModelBase.h"

#include <cpprest/details/basic_types.h>

namespace io {
namespace swagger {
namespace client {
namespace model {

/// <summary>
/// 
/// </summary>
class  Address
    : public ModelBase
{
public:
    Address();
    virtual ~Address();

    /////////////////////////////////////////////
    /// ModelBase overrides

    void validate() override;

    web::json::value toJson() const override;
    void fromJson(web::json::value& json) override;

    void toMultipart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) const override;
    void fromMultiPart(std::shared_ptr<MultipartFormData> multipart, const utility::string_t& namePrefix) override;

    /////////////////////////////////////////////
    /// Address members

    /// <summary>
    /// 
    /// </summary>
    int32_t getId() const;
    bool idIsSet() const;
    void unsetId();
    void setId(int32_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getCurrency() const;
    bool currencyIsSet() const;
    void unsetCurrency();
    void setCurrency(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::datetime getCreated() const;
    bool createdIsSet() const;
    void unsetCreated();
    void setCreated(utility::datetime value);
    /// <summary>
    /// 
    /// </summary>
    double getUserId() const;
    bool userIdIsSet() const;
    void unsetUserId();
    void setUserId(double value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getAddress() const;
        void setAddress(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getName() const;
        void setName(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getNote() const;
    bool noteIsSet() const;
    void unsetNote();
    void setNote(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    bool isSkipConfirm() const;
    bool skipConfirmIsSet() const;
    void unsetSkipConfirm();
    void setSkipConfirm(bool value);
    /// <summary>
    /// 
    /// </summary>
    bool isSkipConfirmVerified() const;
    bool skipConfirmVerifiedIsSet() const;
    void unsetSkipConfirmVerified();
    void setSkipConfirmVerified(bool value);
    /// <summary>
    /// 
    /// </summary>
    bool isSkip2FA() const;
    bool skip2FAIsSet() const;
    void unsetSkip2FA();
    void setSkip2FA(bool value);
    /// <summary>
    /// 
    /// </summary>
    bool isSkip2FAVerified() const;
    bool skip2FAVerifiedIsSet() const;
    void unsetSkip2FAVerified();
    void setSkip2FAVerified(bool value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getNetwork() const;
        void setNetwork(utility::string_t value);
    /// <summary>
    /// 
    /// </summary>
    utility::string_t getMemo() const;
    bool memoIsSet() const;
    void unsetMemo();
    void setMemo(utility::string_t value);

protected:
    int32_t m_Id;
    bool m_IdIsSet;
    utility::string_t m_Currency;
    bool m_CurrencyIsSet;
    utility::datetime m_Created;
    bool m_CreatedIsSet;
    double m_UserId;
    bool m_UserIdIsSet;
    utility::string_t m_Address;
        utility::string_t m_Name;
        utility::string_t m_Note;
    bool m_NoteIsSet;
    bool m_SkipConfirm;
    bool m_SkipConfirmIsSet;
    bool m_SkipConfirmVerified;
    bool m_SkipConfirmVerifiedIsSet;
    bool m_Skip2FA;
    bool m_Skip2FAIsSet;
    bool m_Skip2FAVerified;
    bool m_Skip2FAVerifiedIsSet;
    utility::string_t m_Network;
        utility::string_t m_Memo;
    bool m_MemoIsSet;
};

}
}
}
}

#endif /* IO_SWAGGER_CLIENT_MODEL_Address_H_ */
