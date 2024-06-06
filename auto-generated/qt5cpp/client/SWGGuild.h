/**
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * SWGGuild.h
 *
 * 
 */

#ifndef SWGGuild_H_
#define SWGGuild_H_

#include <QJsonObject>


#include "SWGObject.h"
#include <QDateTime>
#include <QString>

#include "SWGObject.h"

namespace Swagger {

class SWGGuild: public SWGObject {
public:
    SWGGuild();
    SWGGuild(QString json);
    ~SWGGuild();
    void init();
    void cleanup();

    QString asJson () override;
    QJsonObject asJsonObject() override;
    void fromJsonObject(QJsonObject json) override;
    SWGGuild* fromJson(QString jsonString) override;

    qint32 getId();
    void setId(qint32 id);

    QDateTime* getCreated();
    void setCreated(QDateTime* created);

    QDateTime* getUpdated();
    void setUpdated(QDateTime* updated);

    bool isArchived();
    void setArchived(bool archived);

    QString* getName();
    void setName(QString* name);

    QString* getImgUrl();
    void setImgUrl(QString* img_url);

    QString* getMobileHeroImgUrl();
    void setMobileHeroImgUrl(QString* mobile_hero_img_url);

    QString* getEmoji();
    void setEmoji(QString* emoji);

    QString* getLogoUrl();
    void setLogoUrl(QString* logo_url);

    QString* getDescription();
    void setDescription(QString* description);

    double getChatChannelId();
    void setChatChannelId(double chat_channel_id);

    bool isIsPrivate();
    void setIsPrivate(bool is_private);

    QString* getAffiliateId();
    void setAffiliateId(QString* affiliate_id);

    SWGObject* getPotDistributionPreferences();
    void setPotDistributionPreferences(SWGObject* pot_distribution_preferences);

    SWGObject* getSocials();
    void setSocials(SWGObject* socials);

    bool isDeleted();
    void setDeleted(bool deleted);


    virtual bool isSet() override;

private:
    qint32 id;
    bool m_id_isSet;

    QDateTime* created;
    bool m_created_isSet;

    QDateTime* updated;
    bool m_updated_isSet;

    bool archived;
    bool m_archived_isSet;

    QString* name;
    bool m_name_isSet;

    QString* img_url;
    bool m_img_url_isSet;

    QString* mobile_hero_img_url;
    bool m_mobile_hero_img_url_isSet;

    QString* emoji;
    bool m_emoji_isSet;

    QString* logo_url;
    bool m_logo_url_isSet;

    QString* description;
    bool m_description_isSet;

    double chat_channel_id;
    bool m_chat_channel_id_isSet;

    bool is_private;
    bool m_is_private_isSet;

    QString* affiliate_id;
    bool m_affiliate_id_isSet;

    SWGObject* pot_distribution_preferences;
    bool m_pot_distribution_preferences_isSet;

    SWGObject* socials;
    bool m_socials_isSet;

    bool deleted;
    bool m_deleted_isSet;

};

}

#endif /* SWGGuild_H_ */
